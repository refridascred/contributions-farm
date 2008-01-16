-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (owner, token, state, label) VALUES ('stable', 'open', 'standard', 'standard');
INSERT INTO layout_items (owner, token, state, label) VALUES ('green', 'latest', 'legacy', 'local');
INSERT INTO layout_items (owner, token, state, label) VALUES ('eu-west', 'stable', 'stable', 'staging');
