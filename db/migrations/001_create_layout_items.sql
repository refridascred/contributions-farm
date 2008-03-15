-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (owner, score, ratio, rank) VALUES ('standard', 53.49, 55.83, 55);
INSERT INTO layout_items (owner, score, ratio, rank) VALUES ('standard', 6.78, 93.67, 65);
