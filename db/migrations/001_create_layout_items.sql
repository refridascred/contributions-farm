-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (ratio, level, owner, weight) VALUES (31.39, 11, 'standard', 59.76);
INSERT INTO layout_items (ratio, level, owner, weight) VALUES (38.41, 55, 'stable', 62.6);
INSERT INTO layout_items (ratio, level, owner, weight) VALUES (82.51, 84, 'fallback', 30.63);
