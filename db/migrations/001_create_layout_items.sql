-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (token, active, owner, level) VALUES ('eu-west', 91, 'local', 5);
INSERT INTO layout_items (token, active, owner, level) VALUES ('strict', 90, 'blue', 62);
INSERT INTO layout_items (token, active, owner, level) VALUES ('local', 30, 'edge', 90);
