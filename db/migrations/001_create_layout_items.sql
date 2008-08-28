-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, token, level) VALUES (25.92, 'open', 22);
INSERT INTO layout_items (ratio, token, level) VALUES (51.39, 'standard', 6);
INSERT INTO layout_items (ratio, token, level) VALUES (73.9, 'eu-west', 80);
