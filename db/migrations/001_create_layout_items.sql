-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (level, ratio, token) VALUES (0, 95.95, 'stable');
INSERT INTO layout_items (level, ratio, token) VALUES (66, 50.64, 'legacy');
INSERT INTO layout_items (level, ratio, token) VALUES (94, 69.38, 'staging');
