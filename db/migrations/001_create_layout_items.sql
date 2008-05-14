-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (weight, ratio, rank, active) VALUES (35.28, 68.53, 26, 25);
INSERT INTO layout_items (weight, ratio, rank, active) VALUES (88.46, 40.33, 24, 64);
INSERT INTO layout_items (weight, ratio, rank, active) VALUES (6.06, 58.08, 23, 53);
