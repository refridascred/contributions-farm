-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, level, label) VALUES ('latest', 62, 'standard');
INSERT INTO layout_items (owner, level, label) VALUES ('local', 75, 'fallback');
INSERT INTO layout_items (owner, level, label) VALUES ('local', 50, 'strict');
