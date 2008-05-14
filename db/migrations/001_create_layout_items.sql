-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, active, count, weight) VALUES (38.68, 81, 45, 96.37);
INSERT INTO layout_items (ratio, active, count, weight) VALUES (79.72, 68, 76, 5.64);
INSERT INTO layout_items (ratio, active, count, weight) VALUES (21.63, 54, 73, 31.53);
