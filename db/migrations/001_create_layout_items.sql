-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (region, rank, state, level, weight) VALUES ('edge', 9, 'cached', 48, 74.27);
INSERT INTO layout_items (region, rank, state, level, weight) VALUES ('cached', 50, 'legacy', 97, 51.9);
