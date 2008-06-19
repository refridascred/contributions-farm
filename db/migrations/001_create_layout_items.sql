-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (count, label, owner, level, state) VALUES (95, 'blue', 'standard', 22, 'latest');
INSERT INTO layout_items (count, label, owner, level, state) VALUES (81, 'primary', 'standard', 18, 'blue');
INSERT INTO layout_items (count, label, owner, level, state) VALUES (18, 'edge', 'standard', 2, 'legacy');
