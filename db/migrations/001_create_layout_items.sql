-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, label) VALUES (15.91, 'staging');
INSERT INTO layout_items (ratio, label) VALUES (62.08, 'stable');
INSERT INTO layout_items (ratio, label) VALUES (42.91, 'legacy');
