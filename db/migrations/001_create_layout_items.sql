-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    rank INTEGER,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (ratio, token, rank, level, label) VALUES (19.96, 'green', 85, 8, 'legacy');
INSERT INTO layout_items (ratio, token, rank, level, label) VALUES (74.78, 'fallback', 69, 30, 'primary');
INSERT INTO layout_items (ratio, token, rank, level, label) VALUES (21.26, 'primary', 82, 44, 'standard');
