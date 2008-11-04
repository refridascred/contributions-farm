-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (region, ratio, active, label) VALUES ('legacy', 60.18, 19, 'primary');
INSERT INTO layout_items (region, ratio, active, label) VALUES ('stable', 85.68, 67, 'blue');
