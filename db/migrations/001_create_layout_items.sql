-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (label, active, level, count, ratio) VALUES ('latest', 90, 67, 60, 60.19);
INSERT INTO layout_items (label, active, level, count, ratio) VALUES ('edge', 60, 66, 28, 39.52);
INSERT INTO layout_items (label, active, level, count, ratio) VALUES ('local', 9, 25, 22, 26.99);
