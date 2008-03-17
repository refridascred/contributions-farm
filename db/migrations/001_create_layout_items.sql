-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, token, label) VALUES (6.38, 'blue', 'fallback');
INSERT INTO layout_items (ratio, token, label) VALUES (48.49, 'fallback', 'fallback');
INSERT INTO layout_items (ratio, token, label) VALUES (21.08, 'stable', 'cached');
