-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (state, region, owner, level, label) VALUES ('eu-west', 'primary', 'eu-west', 20, 'cached');
INSERT INTO layout_items (state, region, owner, level, label) VALUES ('edge', 'fallback', 'fallback', 54, 'standard');
