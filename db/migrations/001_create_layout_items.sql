-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, level, owner) VALUES (50.0, 5, 'legacy');
INSERT INTO layout_items (ratio, level, owner) VALUES (4.04, 49, 'eu-west');
INSERT INTO layout_items (ratio, level, owner) VALUES (56.83, 24, 'open');
