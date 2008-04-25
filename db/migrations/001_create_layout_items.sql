-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, state, region, ratio) VALUES (14, 'eu-west', 'cached', 1.49);
