-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    ratio REAL,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, token, ratio, weight, level) VALUES ('strict', 'fallback', 1.39, 16.78, 53);
INSERT INTO layout_items (owner, token, ratio, weight, level) VALUES ('latest', 'fallback', 89.69, 20.32, 58);
