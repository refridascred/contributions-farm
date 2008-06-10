-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (region, ratio, owner, weight, token) VALUES ('green', 75.87, 'cached', 47.55, 'standard');
INSERT INTO layout_items (region, ratio, owner, weight, token) VALUES ('latest', 77.31, 'primary', 94.86, 'stable');
INSERT INTO layout_items (region, ratio, owner, weight, token) VALUES ('green', 46.01, 'primary', 90.9, 'blue');
