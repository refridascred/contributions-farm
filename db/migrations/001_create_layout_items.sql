-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (level, active, count, ratio) VALUES (24, 10, 42, 68.66);
INSERT INTO layout_items (level, active, count, ratio) VALUES (9, 87, 67, 33.01);
INSERT INTO layout_items (level, active, count, ratio) VALUES (85, 71, 40, 16.92);
