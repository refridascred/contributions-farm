-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    weight REAL,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (level, ratio, weight, owner, token) VALUES (78, 0.4, 5.49, 'legacy', 'primary');
INSERT INTO layout_items (level, ratio, weight, owner, token) VALUES (7, 4.25, 49.72, 'strict', 'strict');
INSERT INTO layout_items (level, ratio, weight, owner, token) VALUES (12, 39.41, 22.9, 'open', 'green');
