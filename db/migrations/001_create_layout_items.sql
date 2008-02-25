-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (weight, token, level) VALUES (39.6, 'open', 47);
INSERT INTO layout_items (weight, token, level) VALUES (10.93, 'stable', 73);
