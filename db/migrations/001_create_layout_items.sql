-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (label, level, region, state) VALUES ('legacy', 73, 'legacy', 'legacy');
INSERT INTO layout_items (label, level, region, state) VALUES ('fallback', 9, 'eu-west', 'legacy');
