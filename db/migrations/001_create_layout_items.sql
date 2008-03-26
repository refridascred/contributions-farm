-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, active, ratio, count) VALUES (93, 16, 7.4, 18);
INSERT INTO layout_items (level, active, ratio, count) VALUES (73, 85, 67.12, 33);
INSERT INTO layout_items (level, active, ratio, count) VALUES (68, 24, 18.04, 11);
