-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (label, rank, score, ratio) VALUES ('primary', 81, 40.09, 8.05);
INSERT INTO layout_items (label, rank, score, ratio) VALUES ('open', 48, 57.08, 86.93);
