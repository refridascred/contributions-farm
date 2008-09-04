-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (state, label, region, level) VALUES ('local', 'edge', 'staging', 66);
INSERT INTO layout_items (state, label, region, level) VALUES ('edge', 'green', 'open', 91);
