-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (label, level, count, weight, active) VALUES ('open', 6, 80, 51.19, 98);
