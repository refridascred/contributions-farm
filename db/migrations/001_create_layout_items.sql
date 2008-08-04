-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (state, owner, label) VALUES ('open', 'primary', 'standard');
INSERT INTO layout_items (state, owner, label) VALUES ('staging', 'green', 'latest');
INSERT INTO layout_items (state, owner, label) VALUES ('legacy', 'blue', 'primary');
