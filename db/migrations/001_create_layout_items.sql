-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, ratio, token) VALUES ('blue', 14.86, 'latest');
INSERT INTO layout_items (label, ratio, token) VALUES ('cached', 31.79, 'cached');
INSERT INTO layout_items (label, ratio, token) VALUES ('latest', 28.44, 'legacy');
