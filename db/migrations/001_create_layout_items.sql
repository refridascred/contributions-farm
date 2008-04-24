-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, region, label, active, level) VALUES (1.21, 'green', 'blue', 5, 42);
INSERT INTO layout_items (ratio, region, label, active, level) VALUES (16.84, 'blue', 'legacy', 68, 79);
