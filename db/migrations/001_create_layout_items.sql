-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (ratio, state, token, rank) VALUES (63.86, 'primary', 'blue', 51);
INSERT INTO layout_items (ratio, state, token, rank) VALUES (47.54, 'primary', 'strict', 19);
INSERT INTO layout_items (ratio, state, token, rank) VALUES (47.34, 'latest', 'open', 10);
