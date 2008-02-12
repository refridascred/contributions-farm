-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, state, level, token) VALUES ('legacy', 'open', 56, 'latest');
INSERT INTO layout_items (label, state, level, token) VALUES ('standard', 'staging', 17, 'cached');
INSERT INTO layout_items (label, state, level, token) VALUES ('strict', 'primary', 34, 'standard');
