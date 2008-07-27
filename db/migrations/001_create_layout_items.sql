-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, token, owner, level, weight) VALUES (13.99, 'stable', 'stable', 87, 17.24);
INSERT INTO layout_items (ratio, token, owner, level, weight) VALUES (5.02, 'local', 'cached', 51, 44.32);
