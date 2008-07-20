-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, owner, token) VALUES ('latest', 'stable', 'latest');
INSERT INTO layout_items (label, owner, token) VALUES ('eu-west', 'primary', 'stable');
