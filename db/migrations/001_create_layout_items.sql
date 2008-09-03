-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (rank, label, ratio, score) VALUES (37, 'green', 51.73, 13.95);
INSERT INTO layout_items (rank, label, ratio, score) VALUES (30, 'staging', 17.62, 77.29);
INSERT INTO layout_items (rank, label, ratio, score) VALUES (40, 'legacy', 92.74, 66.52);
