-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (ratio, weight, level) VALUES (65.61, 78.35, 10);
INSERT INTO layout_items (ratio, weight, level) VALUES (91.45, 30.34, 31);
INSERT INTO layout_items (ratio, weight, level) VALUES (7.01, 6.13, 61);
