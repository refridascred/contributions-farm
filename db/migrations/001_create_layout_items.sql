-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, ratio, state, region, owner) VALUES (84, 92.21, 'standard', 'strict', 'legacy');
INSERT INTO layout_items (level, ratio, state, region, owner) VALUES (72, 40.32, 'primary', 'local', 'eu-west');
