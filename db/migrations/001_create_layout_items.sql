-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (ratio, level, label, count, active) VALUES (85.46, 58, 'strict', 39, 20);
INSERT INTO layout_items (ratio, level, label, count, active) VALUES (9.94, 36, 'staging', 2, 89);
INSERT INTO layout_items (ratio, level, label, count, active) VALUES (62.79, 4, 'primary', 93, 72);
