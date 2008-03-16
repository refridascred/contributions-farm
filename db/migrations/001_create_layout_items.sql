-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (label, level, owner, state) VALUES ('legacy', 3, 'fallback', 'blue');
INSERT INTO layout_items (label, level, owner, state) VALUES ('staging', 60, 'cached', 'cached');
INSERT INTO layout_items (label, level, owner, state) VALUES ('green', 60, 'legacy', 'legacy');
