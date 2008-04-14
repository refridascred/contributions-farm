-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (token, ratio, level, owner) VALUES ('stable', 74.53, 19, 'cached');
INSERT INTO layout_items (token, ratio, level, owner) VALUES ('blue', 85.92, 75, 'cached');
INSERT INTO layout_items (token, ratio, level, owner) VALUES ('latest', 13.87, 27, 'stable');
