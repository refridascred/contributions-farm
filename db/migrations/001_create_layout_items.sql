-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (ratio, label, rank, score) VALUES (5.78, 'staging', 39, 5.43);
INSERT INTO layout_items (ratio, label, rank, score) VALUES (9.87, 'blue', 34, 60.55);
