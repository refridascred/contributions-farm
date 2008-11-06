-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (rank, state, level, token) VALUES (98, 'fallback', 15, 'edge');
INSERT INTO layout_items (rank, state, level, token) VALUES (29, 'green', 48, 'open');
INSERT INTO layout_items (rank, state, level, token) VALUES (25, 'eu-west', 10, 'legacy');
