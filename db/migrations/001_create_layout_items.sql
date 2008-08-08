-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (owner, token, label) VALUES ('staging', 'edge', 'primary');
INSERT INTO layout_items (owner, token, label) VALUES ('local', 'primary', 'green');
INSERT INTO layout_items (owner, token, label) VALUES ('standard', 'legacy', 'cached');
