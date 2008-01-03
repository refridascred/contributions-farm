-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (level, label, weight, token) VALUES (66, 'latest', 53.9, 'primary');
INSERT INTO layout_items (level, label, weight, token) VALUES (46, 'cached', 22.29, 'local');
