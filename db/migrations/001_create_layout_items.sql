-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, count, token) VALUES (43, 23, 'local');
INSERT INTO layout_items (rank, count, token) VALUES (66, 96, 'cached');
INSERT INTO layout_items (rank, count, token) VALUES (69, 81, 'stable');
