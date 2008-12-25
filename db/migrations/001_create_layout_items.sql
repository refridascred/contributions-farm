-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    weight REAL,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, weight, level, ratio) VALUES ('open', 6.84, 74, 15.39);
INSERT INTO layout_items (owner, weight, level, ratio) VALUES ('open', 39.04, 55, 19.54);
INSERT INTO layout_items (owner, weight, level, ratio) VALUES ('fallback', 79.15, 23, 37.29);
