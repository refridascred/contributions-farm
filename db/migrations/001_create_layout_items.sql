-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, owner, level, weight, ratio) VALUES ('staging', 'fallback', 62, 37.87, 9.49);
