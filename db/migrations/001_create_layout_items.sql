-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (ratio, level, owner) VALUES (47.21, 65, 'strict');
INSERT INTO layout_items (ratio, level, owner) VALUES (28.5, 3, 'legacy');
