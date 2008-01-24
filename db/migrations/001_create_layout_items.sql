-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    label TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (region, label, ratio, rank) VALUES ('green', 'standard', 10.35, 91);
INSERT INTO layout_items (region, label, ratio, rank) VALUES ('open', 'stable', 86.84, 45);
INSERT INTO layout_items (region, label, ratio, rank) VALUES ('fallback', 'legacy', 46.0, 79);
