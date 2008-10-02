-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (region, ratio, count, active) VALUES ('legacy', 14.54, 28, 63);
INSERT INTO layout_items (region, ratio, count, active) VALUES ('green', 69.1, 44, 68);
INSERT INTO layout_items (region, ratio, count, active) VALUES ('strict', 22.72, 46, 87);
