-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (level, ratio, rank) VALUES (95, 4.65, 52);
INSERT INTO layout_items (level, ratio, rank) VALUES (84, 57.38, 19);
