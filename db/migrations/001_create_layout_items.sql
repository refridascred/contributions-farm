-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, label) VALUES (87, 'fallback');
INSERT INTO layout_items (level, label) VALUES (8, 'cached');
INSERT INTO layout_items (level, label) VALUES (11, 'standard');
