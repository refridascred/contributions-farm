-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, ratio, label) VALUES ('open', 9.28, 'legacy');
INSERT INTO layout_items (token, ratio, label) VALUES ('cached', 54.11, 'local');
