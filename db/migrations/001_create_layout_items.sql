-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    created_at TIMESTAMP,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (weight, rank, level, label) VALUES (28.65, 51, 91, 'primary');
INSERT INTO layout_items (weight, rank, level, label) VALUES (4.49, 9, 84, 'staging');
INSERT INTO layout_items (weight, rank, level, label) VALUES (27.92, 82, 28, 'stable');
