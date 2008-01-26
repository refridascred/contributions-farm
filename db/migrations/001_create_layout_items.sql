-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, weight, token) VALUES (90, 14.84, 'stable');
INSERT INTO layout_items (rank, weight, token) VALUES (24, 42.1, 'staging');
