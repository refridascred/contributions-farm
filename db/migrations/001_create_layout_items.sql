-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (weight, rank, token, state, level) VALUES (5.75, 24, 'edge', 'local', 49);
INSERT INTO layout_items (weight, rank, token, state, level) VALUES (51.84, 28, 'legacy', 'open', 85);
INSERT INTO layout_items (weight, rank, token, state, level) VALUES (39.11, 12, 'eu-west', 'cached', 46);
