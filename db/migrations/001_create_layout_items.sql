-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, token, weight, level) VALUES (5.62, 'green', 24.11, 27);
INSERT INTO layout_items (ratio, token, weight, level) VALUES (22.03, 'local', 90.57, 59);
INSERT INTO layout_items (ratio, token, weight, level) VALUES (53.55, 'eu-west', 65.58, 13);
