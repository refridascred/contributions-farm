-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (label, count, rank, score) VALUES ('primary', 9, 76, 61.42);
INSERT INTO layout_items (label, count, rank, score) VALUES ('edge', 31, 55, 13.53);
INSERT INTO layout_items (label, count, rank, score) VALUES ('eu-west', 11, 6, 39.03);
