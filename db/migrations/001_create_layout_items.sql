-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (label, count, rank, score) VALUES ('edge', 94, 73, 34.52);
INSERT INTO layout_items (label, count, rank, score) VALUES ('latest', 55, 99, 27.6);
INSERT INTO layout_items (label, count, rank, score) VALUES ('strict', 28, 14, 92.04);
