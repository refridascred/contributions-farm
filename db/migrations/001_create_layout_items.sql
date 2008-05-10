-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, active, label) VALUES (80.95, 88, 'standard');
INSERT INTO layout_items (ratio, active, label) VALUES (12.79, 3, 'blue');
INSERT INTO layout_items (ratio, active, label) VALUES (0.33, 8, 'strict');
