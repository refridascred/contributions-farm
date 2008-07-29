-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (owner, weight, ratio, count, token) VALUES ('primary', 72.33, 4.87, 38, 'fallback');
INSERT INTO layout_items (owner, weight, ratio, count, token) VALUES ('open', 6.7, 53.98, 16, 'standard');
INSERT INTO layout_items (owner, weight, ratio, count, token) VALUES ('cached', 6.77, 81.88, 88, 'strict');
