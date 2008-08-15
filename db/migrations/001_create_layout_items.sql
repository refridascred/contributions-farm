-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (state, region, active, label, level) VALUES ('legacy', 'cached', 82, 'cached', 70);
INSERT INTO layout_items (state, region, active, label, level) VALUES ('cached', 'staging', 14, 'standard', 27);
